-- このluaスクリプトは、CO_101032_0604.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:兄さんはさたまにアレだけど、すごく優しいんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040002")


	--★★ガレス★★:みんなの困った顔が苦手で誰かが泣いてると一緒になって泣いてあげて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040003")

	open_select_window_tag(Actor001,"Normal","CO_101032_06040005","CO_101032_06040006","CO_101032_06040007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかに、たまにアレだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:だろう？わかってもらえて嬉しいぞ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040010")

-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:なあなあアレってどういうことなんだ？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06040011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:アレはアレだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ヒーローだよな、あいつ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:学園以外にも友達たくさんいてみんなから好かれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:うん…うん！自慢の兄さんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もあいつに助けてもらったこと何回もあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040019")

	change_face(Actor001,"Smile")

	--★★ノワール★★:なんの得にもならなそうなことでもイヤな顔ひとつせず付き合ってくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040020")

	change_face(Actor001,"Smile")

	--★★ノワール★★:「俺たちダチだろ？ダチをひとりにしちゃおけねーよ」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040021")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:わたしもいっつも励ましてもらってたよ…たまにケンカもしたけどね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040022")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:わたしが「円卓の騎士になる」って言ったときさ兄さん、最初は反対してきたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガレス★★:「女の子がなるもんじゃねー！」って、すごい剣幕で怒られた
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040025")


	--★★ガレス★★:でも、少ししたらこう言って謝ってきたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガレス★★:「妹のやりたいことを応援してやれなかったら兄貴失格だよな」って
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040027")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガウェイン、そんなことを…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06040028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:そのあと、円卓のみんなに私を推薦してくれた「俺を信じてください」って頭を下げてね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040029")

-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ほんと、『太陽のヒーロー』なんだよ、兄さんいつもわたしを笑顔にしてくれるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040030")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ガレス★★:だから…<br>間違ってるなんて、言えないよ…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06040031")

-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:ガレス…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06040032")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
