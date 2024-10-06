-- このluaスクリプトは、MA_01105_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:また、サボリ？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:ま、な。それよりオニーサン<br>王妃殿下のご実家を無事取り返したんだって？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:…えへへ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430004")


	--★★マルディサント★★:アンタは出撃のお呼びがかかんなかった
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:うん。だから私<br>少しでもお勉強しようと思って
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:オニーサンは陰口叩かれつつも<br>円卓の騎士になっちまって、戦果も挙げた
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430008")


	--★★マルディサント★★:アンタはフェアリーとかアイドル扱いされつつも<br>カビくせえこんなとこで悪い子とお喋り
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:えへへ…、勉強不足だからねえ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430010")


	--★★マルディサント★★:本当のところ、どうなんだよ<br>お勉強が大好きなのか、非行少女が大好きなのか
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430011")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ええっ…？<br>べ、別に、どっちも…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:どっちも？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430014")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:どっちも…<br>ふつうに、ふつう
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:フツーにフツーねえ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430017")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:お勉強は学生の本分ですからっ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01105_430018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルディサント★★:………良い子ちゃんめ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:よくそんなに<br>演じてられるよな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01105_430020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
