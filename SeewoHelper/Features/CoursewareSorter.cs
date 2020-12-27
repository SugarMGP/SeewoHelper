﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SeewoHelper.Features
{
    public class CoursewareSorter
    {
        private readonly IEnumerable<SubjectStorageInfo> _subjectStorageInfos;

        private readonly DirectoryInfo _directory;

        public void SortMore()
        {
            Program.Logger.Add(new Log("开始整理课件"));

            foreach (var info in _subjectStorageInfos)
            {
                Sort(info);
            }

            Program.Logger.Add(new Log("整理课件完成"));
        }

        private void Sort(SubjectStorageInfo info)
        {
            var fileSystemInfos = _directory.GetFileSystemInfos();
            var selectedFileSystemInfos = new List<FileSystemInfo>();

            Program.Logger.Add(new Log($"开始整理科目：{info.Name}，目标路径：{info.Path}"));

            foreach (string keyword in info.Keywords)
            {
                Program.Logger.Add(new Log($"正在匹配关键词：{keyword}"));

                var regex = new Regex(keyword);
                var matchedFileSystemInfos = fileSystemInfos.Where(x => regex.IsMatch(x.Name));

                selectedFileSystemInfos.AddRange(matchedFileSystemInfos);

                Program.Logger.Add(new Log($"匹配到：{string.Join("/", matchedFileSystemInfos)}"));
            }

            var processFileSystemInfos = selectedFileSystemInfos.Distinct();

            Program.Logger.Add(new Log($"将要处理：{string.Join("/", processFileSystemInfos)}"));

            foreach (var fileSysmteInfo in processFileSystemInfos)
            {
                Program.Logger.Add(new Log($"正在移动：{fileSysmteInfo}"));

                fileSysmteInfo.MoveTo(Path.Combine(info.Path, fileSysmteInfo.Name), true);
            }

            Program.Logger.Add(new Log($"科目 {info.Name} 整理完成"));
        }

        public CoursewareSorter(CoursewareSortingInfo info)
        {
            _subjectStorageInfos = info.Subjects;
            _directory = new DirectoryInfo(info.Path);
        }
    }
}
