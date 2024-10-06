-- このluaスクリプトは、MA_01C201_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C201_081001")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C201_081002")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C201_081003")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C201_081004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:斥候部隊から報告があった<br>ギネヴィアの目撃情報があったらしい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C201_080002")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:皇太子サマがダンマリってことは<br>今度はローマの手柄じゃねえってことだな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080003")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:ログレスの狂犬はやたらと吠えるな<br>躾がなっていないようだ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_080005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★モルドレッド★★:あ？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080006")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:どうでもいいでしょ、そんなこと<br>それより、本題
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01C201_080007")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:ギネヴィアの目撃情報があったのは<br>キャメリアード周辺だよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01C201_080008")

	change_face(Actor003,"Normal")

	--★★モルドレッド★★:こんな状況で<br>呑気に里帰り…ってわけじゃねぇよなぁ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ああ。キャメリアードは依然<br>バルバロイが跋扈する状況のはずだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C201_080010")


	--★★ケイ★★:そんな場所で、いったいなにを…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C201_080011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_080012","MA_01C201_080013","MA_01C201_080014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネマウアさんもいたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080016")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:さすがにそこまではわからないよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01C201_080017")

	change_face(Actor004,"Normal")

	--★★トリスタン★★:ギネヴィアはあれで目立つから<br>目撃情報も探しやすいんだけど…
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01C201_080018")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:バルバロイがウジャウジャいるなかに<br>キラーズなしってことはねぇだろ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだよな…<br>なら、きっとギネヴィアは大丈夫なはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080020")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ルーシャス★★:…気にするべきは<br>そこではないと思うがな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_080021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:会って、話を聞けばわかる<br>ギネヴィアをさがしに行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080023")

-- ▼直接出力
set_enable_auto_lookat(Actor005, false)

lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor005, lookWeight,0.5)
keep_ik_lookat(Actor005, Actor001, "J_Head")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:よいのか？話を聞けば<br>不都合なこともあるかもしれんぞ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_080024")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)

lookat_delay_weight(Actor001, 0.9, 0, 0.5, 0.35,0.5)
keep_ik_lookat(Actor001, Actor005, "J_Head")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだよ、不都合なことって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080025")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:たとえば王と王妃がヨリを戻したとかな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_080026")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★トリスタン★★:皇太子殿下って意外と下世話なんだね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01C201_080027")

-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 1)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だとしても…話を聞かなきゃ始まらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080028")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:それもそうだな<br>判断は継承者に任せるとしよう
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C201_080029")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight(Actor001, 0.9, 0, 0.5, 0.35,0.5)
keep_ik_lookat(Actor001, Actor006, "J_Head")
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どう思う、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080031")

-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ディナタン★★:私は…
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C201_080032")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ディナタン★★:…さがしてほしいんじゃないかなって
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C201_080033")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Sad")

	--★★ディナタン★★:帰りたいところがあって<br>でも、帰れなくて…だから――
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C201_080034")

	change_face(Actor003,"Normal")

	--★★モルドレッド★★:自分だけ生き延びて<br>合わせる顔がねえってか？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だったら、迎えに行ってやらないとな<br>きっと心細いはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080037")

-- ▼直接出力
lookat_delay_weight(Actor006, 0.9, 0, 0.5, 0.35,0.5)
keep_ik_lookat(Actor006, Actor001, "J_Head")
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ディナタン★★:兄さん…！うん、そうだよね
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C201_080038")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.5)
 --PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:キャメリアードは未だ危険地帯だ<br>向かうのであればしっかり準備するといい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C201_080040")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:俺は元王妃様のお守りなんざ勘弁だぜ<br>行くならてめえらだけで行け
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C201_080041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_080042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
