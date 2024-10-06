-- このluaスクリプトは、MA_01B110_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Knight2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020011)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:他人の名。真似事の僕
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090002")


	--★★テロップ★★:「貴方の銀色はまるで…」
	Talk(Actor002,"telop","narration","N","MA_01B110_090003")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:騎士として<br>舗装された道を歩むだけなんて不名誉だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090004")


	--★★テロップ★★:「まるで、鏡みたいね」
	Talk(Actor002,"telop","narration","N","MA_01B110_090005")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:この銀色がただ<br>誰かを映すだけなんて
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090006")

-- ▼直接出力
DontChangeRandomCamera(false)
bgm_play("BGM_ADV_Knight2")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:成ってみせるんだ<br>お爺様が望む姿ならなんにだって
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090009")

	change_face(Actor001,"Normal")

	--★★ガラハッド★★:いずれは『ランスロット』にすら追いついて<br>『ガラハッド』を返上してやるんだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:カーライル城の例をみれば恐らく<br>姉上が探知した場所に魔女はいる…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090011")


	--★★ガラハッド★★:銀卓騎士もいるはずだ！！<br>魔女を討ち、彼らから本当を聞き出す！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090012")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:きっと操られているんだ<br>思ってもいないことをさせられてる
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090014")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:バルバロイの侵蝕は早いと聞く…！<br>急げ、急げ、急げガラハッド！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:そして聖杯も見つけて──<br>欲張りだ、欲張りだが、僕はそうしなければ…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:継承者より先に証を立てなければ…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090017")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ガラハッド★★:物申してやるんだ<br>ガラハッド
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090019")


	--★★ガラハッド★★:ランスロットに言ってやれ…！<br>本当の僕を見てもらうために！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "気合い")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:「あなたのおさがりはうんざりだ」と！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_090021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Knight2")
	InitializeLoad_Preload()
	load_duel_scene_preload(101020011)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
