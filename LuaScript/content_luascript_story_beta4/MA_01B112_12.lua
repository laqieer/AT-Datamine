-- このluaスクリプトは、MA_01B112_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_05","110011_05_h")
Include("content_adv_advsmall_110011_05","Template110011_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_05_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_005)
	InitializeTemplateRandomCamera110011_05()
	InitializeTemplate110011_05()
-- ▼直接出力
Hide(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ディナタンに勉強を<br>教えてもらおうと思ったんだが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:スノードンの戦いで<br>負傷した人の対応に追われてるんだ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_120003")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ガラハッド★★:…ガラハッドたちも<br>悠長にしている場合ではないか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120004")

-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,95.01859,0,1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:サボれるときにサボっとけよ<br>オニーサン
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B112_120006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,83.858,0,0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ひ、非行少女…っ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120007")

	PlayAction(Actor003,"to LookFor")

	--★★マルディサント★★:ズイブンじゃねえか<br>ディーナからの預かり物やんねえぞお
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B112_120008")

	PlayAction(Actor003,"to Show")

	--★★マルディサント★★:ディーナがまとめた<br>マル秘復習ノート
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B112_120010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:か、感謝する…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120011")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:礼はディーナにな<br>非行少女は華麗にフケるぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B112_120012")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01B112_12_Foot")
Hide(Actor003)
turn(Actor002,0,278.0352,0,0.1)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:俺たちも帰ろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_120014")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:あー、あの、ノワール<br>ちょっとだけ…ちょっとだけ、な…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120016")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:僕を、勉強していかないか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_120018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
