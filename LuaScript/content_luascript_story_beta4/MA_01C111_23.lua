-- このluaスクリプトは、MA_01C111_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
halloween_prop = setup_prop_object(10102011)
set_pos(halloween_prop,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101150093)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ハロウィン、楽しんでいますか？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それなりに<br>ギネマウアさんは…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア","肯定")
-- ▲直接出力

	--★★ギネマウア★★:私も、それなりに
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:あの子はとっても<br>楽しんでいるようですね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230005")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネマウア★★:なんだか五月祭を思い出します
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おかげで学園の<br>雰囲気も明るくなってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア","肯定2")
-- ▲直接出力

	--★★ギネマウア★★:…ええ。そう思います
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:あの子はとても成長しました<br>あなたのおかげで
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺は別に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネマウア","悩む")
-- ▲直接出力

	--★★ギネマウア★★:「なんてワガママなお姫様だ」<br>って思いませんでした？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230012")

	open_select_window_tag(Actor001,"Normal","MA_01C111_230015","MA_01C111_230016","MA_01C111_230017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230019")

-- ▼直接出力
 --PlayPartVoice("ギネマウア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:そ、そんなにまっすぐな目で返されるとは<br>思っていませんでした…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:否定はできませんけどね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230021")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:この国に来たばかりの頃は<br>本当にワガママな子だったから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>そう思ったことはないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230024")

-- ▼直接出力
 --PlayPartVoice("ギネマウア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:…本当に？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230025")

-- ▼直接出力
 --PlayPartVoice("ノワール","苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:え、ええ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230026")

-- ▼直接出力
 --PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…少しも？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230027")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…少しは、ある、かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ふふ、そうでしょう？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230029")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:キャメリアードにいた頃からああでした<br>末っ子というのも大きかったのかも
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230030")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:でも、あの子もずいぶん変わりました<br>この学園に来て、貴方たちと出会って
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230031")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あなたとＧＳできたことが<br>きっかけだったんじゃないかと思います
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230032")

-- ▼直接出力
 --PlayPartVoice("ギネマウア","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…そう、だといいのですが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:思ったことがない<br>といえば嘘になるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230036")

-- ▼直接出力
 --PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:本当に手がかかる子でした<br>それがかわいくもあったけど
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230037")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:でも今は自分の気持ちよりも<br>周りのことを思って行動できる
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230038")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:王妃ではなくなった今のほうが<br>よっぽど王妃のよう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230040")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:私はそれが嬉しくて<br>それから少し、怖い
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230041")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★ギネマウア★★:あの子が生きて、幸せでいてくれれば<br>私はそれでいいのに
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネマウアさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_230043")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…そろそろ魔女パレードの時間ですね<br>見に行ってはいかがですか
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230044")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:私はもう少し<br>ここで風にあたっていますから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C111_230045")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102011)
	InitializeLoad_Preload()
	load_duel_scene_preload(101150093)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
