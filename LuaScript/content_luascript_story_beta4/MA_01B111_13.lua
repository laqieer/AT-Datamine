-- このluaスクリプトは、MA_01B111_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_004)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
-- ▼直接出力
Hide(Actor001)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor005,"Sad")

	--★★モルガン★★:弱ったわねえ
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130002")


	--★★アーサー★★:俺のことか。義姉さん？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130003")

	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★モルガン★★:私が<br>幸せ過ぎて弱っちゃう
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:こんなに長い休みは<br>いつぶりだろうな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130005")

	change_face(Actor005,"Normal")

	--★★モルガン★★:…お加減は？
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130006")

	change_face(Actor003,"Smile")

	--★★アーサー★★:残された時間を幸せに過ごしたいな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130008")

	change_face(Actor005,"Sad")

	--★★モルガン★★:笑ってごまかすのは<br>貴方の悪癖よ
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130010")

	change_face(Actor003,"Normal")

	--★★アーサー★★:義姉さんならわかっているだろう？<br>今やこの…血族の病に治療のすべはない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130011")

	PlayAction(Actor005,"to  Std_No")

	--★★モルガン★★:貴方を弱っていくままにはさせないわ<br>なんとしても、なにをしても
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:アーサー、いいんだ<br>口にしないでくれ、もう──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_130013")

	change_face(Actor003,"Sad")

	--★★アーサー★★:もうじき我が天命は尽きる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130014")


	--★★モルガン★★:看取る覚悟なんてさせないで
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130015")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:なにも諦めちゃいないさ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130016")


	--★★アーサー★★:俺には愛すべき家族がいて<br>全幅の信頼を置ける親友がいて
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130017")


	--★★アーサー★★:厳しい魔術師が席を支えてくれて<br>頼もしい騎士たちが卓を囲んでくれている
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130018")

	change_face(Actor003,"Smile")

	--★★アーサー★★:奇跡を見ずに、逝けるものか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor001,Camera001,EntryData111031_01_08,CameraAssetBundleName111031_01,CameraPos111031_01_108,Actor004,CharaPos111031_01_006,CharaPos111031_01_106)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★マーリン★★:陛下<br>お茶会にお仲間が
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_130022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ラクさせてもらってるぞ、ノワール！<br>聖杯まであと一息だ！ガンバ！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_130023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…その件で、話したいことが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_130024")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★モルガン★★:ごめんね、アーサー<br>せっかくだけど私…中座させてもらうわ
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130025")

	change_face(Actor004,"Sad")

	--★★マーリン★★:モルガン…
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_130026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルガン★★:お願いねアーサー<br>年甲斐もなく駄々をこねるようで悪いけれど…
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130028")


	--★★モルガン★★:置いていかないで欲しいだけなのよ、私も
	Talk(Actor005,"CHRNAME_MORGAN","speech","L","MA_01B111_130029")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
