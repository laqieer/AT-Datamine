-- このluaスクリプトは、CO_101015_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-100,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101040","001","101040001")
	Actor007 = InitializeCharacter_2DOnly("101066","001","101066001")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:よし、さっそく行こう！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020002")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ2D★★:ほう。どこへ？
	Talk(Actor006,"CHRNAME_KAY","speech","L","CO_101015_08020003")

-- ▼直接出力
Appear(Actor003)

-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:に、義兄さん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020005")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:まったく…<br>最近は真面目にやっていたかと思えばこれだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:今日は急ぎ決裁しなければならない書類が<br>山積みだと言っていただろう！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020007")

-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:サボりは許さん<br>イスにくくり付けてでも仕事をさせるからな！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020008")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:く…万事休す！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…前もあったな、こんなこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020010")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ2D★★:アーサー様、失礼するぞい
	Talk(Actor007,"CHRNAME_BLAZE","speech","L","CO_101015_08020011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor004)
Appear(Actor005)
wait_time(CHARA_IN_OUT)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(FADE_TIME)
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ブレイズ先生、マーリン<br>その様子…なにかよくない知らせか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020013")


	--★★ブレイズ★★:さすが、察しがよいのう
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020014")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:ローマ兵が大量のバルバロイを引き連れて<br>動きを起こそうとしておる
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マーリン★★:トリスタン様の調査によれば<br>すでに兵の多くが拠点を発ったとのことです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101015_08020017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマ兵の狙いは？まさかこの学園…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020018")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★ブレイズ★★:いいや。奴らの狙いはここじゃ
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020019")

-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:この、村は…！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020020")


	--★★ブレイズ★★:村の周辺では数日前から<br>ローマ兵や下級バルバロイの出没情報があった
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020022")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:恐らくは偵察だったんじゃろうな
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ケイ★★:そ、そんな…！なぜ、こんな田舎を！？<br>狙う意味がないだろう！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020024")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★アーサー★★:…意味があるとすれば、ひとつしかないだろうな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020025")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:俺への挑発だ<br>俺が育った孤児院がこの場所にあるからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020027")

-- ▼直接出力
PlayPartVoice("ブレイズ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ブレイズ★★:はてさて…<br>この村は多くを引き寄せる村じゃな
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020029")


	--★★ブレイズ★★:どういうわけか…先代のマーリンなら<br>いろいろと知っているやもしれんが
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_08020032","CO_101015_08020033","CO_101015_08020034")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは罠だ<br>それくらい、俺にだってわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020036")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど…だからって見捨てるのか？<br>あんたが青春を過ごした故郷なんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020037")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:俺は…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020038")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もし、あんたが俺の立場なら<br>「青春を守れ」ってあんたはきっと言う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは思い出の大切さを<br>一番わかってるからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサー<br>ここで動いちゃダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020043")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマの連中はあんたを狙ってる<br>みすみす罠にはまりに行く必要はない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020044")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:私もノワールの意見に賛成だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020045")

	change_face(Actor003,"Normal")

	--★★ケイ★★:…お前の気持ちもわかるがな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:先代マーリンって、どんな人なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020048")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ブレイズ★★:偉大なる宮廷魔術師じゃよ<br>先王ユーサー様に仕えておられた
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101015_08020049")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…幼い頃、何度か会ったことがある<br>優しくて、とても聡明な方だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020050")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺に王としての在り方を教えてくれた<br>「運命に負けず、強く在れ」と
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020051")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:…とにかく
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020053")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:これが罠だとわかり切っている以上<br>わざわざアーサーの身を危険にさらす必要はない
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020054")


	--★★ケイ★★:それに…今は魔女やローマの軍勢に<br>備えねばならないときなのだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:いたずらに兵を出して<br>ログレスの守りを緩めることはできない…！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020056")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:義兄さん…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020057")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ケイ★★:感傷に流されるな。お前はログレスの王だ<br>その重責を考えろ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_08020058")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.6, 0.2, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_OUT)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうするつもりだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020060")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:…義兄さんの言うことはもっともだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020061")


	--★★アーサー★★:ここで兵を出させ、守りの薄くなった学園を<br>襲撃することがローマの狙いかもしれない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:そうなれば多くの民に被害が及ぶ<br>そんなことは許されない…王として
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020063")


	--★★アーサー★★:…だが――…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020064")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:だったら、俺たちだけでいけばいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ノワール…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020066")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:大切な場所がバルバロイに<br>食い荒らされるかもしれないんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:あんたは、それでいいのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_08020068")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…少し考えさせてくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_08020070")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101040","001","101040001")
	InitializeCharacter_2DOnly_Preload("101066","001","101066001")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
