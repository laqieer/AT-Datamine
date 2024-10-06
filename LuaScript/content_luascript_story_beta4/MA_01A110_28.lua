-- このluaスクリプトは、MA_01A110_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020011)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:成ってみせるんだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280002")


	--★★ガラハッド★★:お爺様が望む姿なら<br>なんにだって
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力

	--★★ガラハッド★★:いずれは『ランスロット』にすら追いついて<br>『ガラハッド』を返上してやるんだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280004")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:バルバロイの侵蝕は早いと聞く…！<br>急げ、急げ、急げガラハッド！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ガラハッド★★:そして聖杯も見つけて──<br>欲張りだ、欲張りだが、僕はそうしなければ…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280006")


	--★★ガラハッド★★:継承者より先に証を立てなければ…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:物申してやるんだ<br>ガラハッド
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280009")


	--★★ガラハッド★★:ランスロットに言ってやれ…！<br>本当の僕を見てもらうために！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280010")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力

	--★★ガラハッド★★:「あなたのおさがりはうんざりだ」と！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01A110_280011")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
change_face(Actor001,"Normal")
wait_time(0.6)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{-10,0, -0.189}, 3.5)
wait_time(0.5)
setup_small_camera_start(RndCamera007)
wait_time(3.0)
PlayActionDirect(Actor001,"to Std_Loop")
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
	load_duel_scene_preload(101020011)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
