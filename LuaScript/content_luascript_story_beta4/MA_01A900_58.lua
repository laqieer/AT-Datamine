-- このluaスクリプトは、MA_01A900_58.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:俺は過去を振り返らないオトコだぜ<br>だからお前が過去になにしてようが知らねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:けど、お前が傷ついたカオしてんのは<br>ちょっと見過ごせねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ラグネル★★:友達想いだねー！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:お前っつー傭兵を<br>買い上げた雇用主がいたよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580005")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:そしてあたしたちに<br>夜明けを見せてくれた人
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:覚えちゃいねーが<br>忘れらんねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580007")

	change_face(Actor003,"Smile")

	--★★ラグネル★★:一緒に授業受けてさ、恋バナしてさ<br>ご飯食べて、笑って、泣いてさ──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580008")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:エレインが手紙まわして、あたしたち集めて<br>病室で雑魚寝したりね。楽しかった
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580009")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ラグネル★★:そんな友達と過ごした時間だけは<br>ずうっと遺ってるもんね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:この学園で<br>お前の初めての武器はソイツだったはずだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580011")

	change_face(Actor003,"Laugh")

	--★★ラグネル★★:その人は、きっと君の──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A900_580012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ヒロインだったよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A900_580013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
