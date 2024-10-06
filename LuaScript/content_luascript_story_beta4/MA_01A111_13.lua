-- このluaスクリプトは、MA_01A111_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_002)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルガン★★:食べごろよ、マーリン<br>これを逃すと来年までないわ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力

	--★★マーリン★★:いいえ、結構です
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "否定")
-- ▲直接出力

	--★★モルガン★★:遠慮しないの<br>手塩にかけた果実たちなんだから
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130004")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:…相も変わらず健やかですよ。彼は
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力

	--★★モルガン★★:おめでとう<br>僥倖に恵まれたわね
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:考えを変えられては？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130010")

	change_face(Actor001,"Normal")

	--★★モルガン★★:彼の、この世界での幸福はあり得ない<br>とても生きづらいのよ…ここは
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:それでも彼が人としての生を望んでいても？<br>あなたは彼の意志を捻じ曲げてまで──
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130013")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:『楽園』に連れていく
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130014")

-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…モルガン<br>それでもあなたは揺れている
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★モルガン★★:いい加減<br>押し問答も飽きたわ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130017")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:彼の均衡は保たれたままです<br>人の身で楽園には至れませんよ
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:貴方自身でこの均衡を崩し<br>彼の願いのひとつすら叶えさせず…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130019")


	--★★マーリン★★:楽園へ引っ張っていき<br>なにが残ります？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130020")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルガン★★:…なら教えてよ、石頭
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルガン★★:愛する者を護る道<br>正しいのはどちらの歩みか
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130023")


	--★★モルガン★★:貴方のように<br>無慈悲な死を確定させるべきか
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルガン★★:私のように<br>永遠の楽園を与えるべきか
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130025")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:………モルガン
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_130026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルガン★★:答えは明白でしょう、違う？
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A111_130027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
