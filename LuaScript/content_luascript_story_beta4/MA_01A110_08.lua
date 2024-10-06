-- このluaスクリプトは、MA_01A110_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102030030_StillImage", "content_still_10203003_image", "102030030_StillImage")
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, true)
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
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A110_081001")


	--★★テロップ★★:諸君、招集をかけたのは他でもない
	Talk(Actor009,"telop","narration","N","MA_01A110_081002")


	--★★テロップ★★:速攻でいこう
	Talk(Actor009,"telop","narration","N","MA_01A110_081003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力

	--★★ケイ★★:諸君、招集をかけたのは他でもない
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A110_080002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:速攻でいこう
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:待ちわびたぜ、アーサー様
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A110_080004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力

	--★★ノワール★★:背後の危機は去った<br>あとは前進あるのみだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:けど、急ぎ招集をかけてきたってことは<br>ローマにも動きがあったのね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080006")


	--★★ケイ★★:聖杯探索班から連絡が入ってな<br>事態は急を要すると
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A110_080007")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Surprise")

	--★★ラヴェイン★★:急を要するとは事態とは？<br>ランスロット卿らが助けを求めるほどの…
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_080008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★アーサー★★:ブリテンが東西に分断されようとしている
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080009")


	--★★トリスタン★★:どういう意味…？
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:キャメリアード城の東に<br>巨大な壁ができあがろうとしているんだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080012")


	--★★アーサー★★:いや、壁といっていいのか…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080014")

-- ▼直接出力
show_image("102030030_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力

	--★★アーサー★★:この地にはかつて巨大な長城があった<br>長く放置され、朽ちるだけのものだったが
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:ルーシャスや魔女が言ってたヤツね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080017")

	change_face(Actor006,"Sad")

	--★★エレイン★★:バルバロイを押しとどめるために<br>古代ローマが築いたと主張していた…
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080018")


	--★★アーサー★★:そこに今、無数のバルバロイが送り込まれている<br>その軍勢は長城に沿って南北に拡がり──
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080019")


	--★★トリスタン★★:さながらブリテン島を分断する壁を<br>作ろうとしてるってこと…？
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080020")

	change_face(Actor004,"Serious")

	--★★ガウェイン★★:んだよソレ…！長城の長さの分だけ<br>バルバロイがいるってことになんのか…！？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A110_080022")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
hide_image(0.3)
-- ▲直接出力

	--★★エレイン★★:ろ、ロンディニウムの比じゃ、ないです…<br>そんなの…
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:長城全域にバルバロイが拡がり切れば<br>もう収拾がつかなくなる
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A110_080024")

	change_face(Actor005,"Sad")

	--★★トリスタン★★:ログレスには南北全域をカバーできるほど<br>物量があるわけではないもんね…
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080025")

	change_face(Actor007,"Sad")

	--★★ラヴェイン★★:そこからはブリテン島西部一帯を覆うようにして<br>バルバロイが蹂躙、増殖を繰り返すことになる…
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_080026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ガウェイン★★:聖杯探索だって東部まで行かなきゃなんねーし<br>カレドニアにも手が届かなくなっちまう…！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A110_080027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:…ランスロットの見立てでは<br>あと数日ほどで壁が完成してしまうそうだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_080030","MA_01A110_080031","MA_01A110_080032")
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
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor001, {0.8, 0.02, 0.5, 0} ,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア、どう思う？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080034")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:雑ね。ルーシャスにしては<br>大帝国が守りに入ってどうすんのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080035")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
lookat_delay_weight_reset(Actor001 , 0.6)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:用心深い男でもある<br>ローマにはない力をこちらは持っている
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080036")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★アーサー★★:GSを果たした騎士たちの力を<br>見極めようとしているのかもしれんな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080037")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:どちらにせよ、らしくないわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_ik_lookat(Actor001, Actor006, "J_Head")
lookat_delay_weight(Actor001, {1.1, 0.02, 0.4, 0} ,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレイン、どう思う？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080041")

	PlayAction(Actor006,"to  Std_Surp")
	change_face(Actor006,"Sad")

	--★★エレイン★★:…えと、えと、あのっ、あのっ…！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ゆっくりでいいから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080043")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_ik_lookat(Actor006, Actor001, "J_Head")
lookat_delay_weight(Actor006, {1.0, 0.08, 0.5, 0} ,0.6)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:…はいっ。先輩
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080044")

-- ▼直接出力
lookat_delay_weight_reset(Actor006 , 0.6)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:あの、なんというか…自己顕示欲が、見えます
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080045")

	change_face(Actor006,"Sad")

	--★★エレイン★★:自分の働きを、誰かに見せたい、といった…<br>ごくごく個人的な、それでいて乱暴な…
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:ルーシャスの仕業…なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080048")

	change_face(Actor004,"Normal")

	--★★ガウェイン★★:魔女を味方につけたんなら<br>できないことじゃねーだろうけど…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A110_080049")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★トリスタン★★:要は、壁周辺に住む人間なんて<br>どうでもいいってわけだ
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080050")

	change_face(Actor005,"Normal")

	--★★トリスタン★★:放っておけば<br>壁を作るバルバロイは増殖するばかりだもんね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080051")

	change_face(Actor003,"Sad")

	--★★アーサー★★:周辺の人間を喰ってな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080052")

	change_face(Actor004,"Sad")

	--★★ガウェイン★★:…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A110_080053")

	goto Block1end

::Block1end::
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
lookat_delay_weight_reset(Actor001 , 1)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★トリスタン★★:…学園から離反者が出てるんだ<br>ほんの数名だけど
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080055")

	change_face(Actor006,"Surprise")

	--★★エレイン★★:え…？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080056")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:先の虐殺の濡れ衣を真に受けたのか<br>ローマとの戦いに逃げ腰になったのか
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:ま、どっちにせよボクは学園内を見張らないとね<br>これ以上こちらの戦力が削がれるのは避けたいし
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080058")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★ラヴェイン★★:ノワール君も仰せでしたがこうなれば<br>ログレスとローマ…どちらを信じるか、ですね
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_080059")


	--★★トリスタン★★:早く皆に「ログレスはバルバロイを討ち<br>世界を救うヒーローだ」ってとこ見せてくれる？
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A110_080060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:任せて<br>そのためにわたしがいるのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080061")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★アーサー★★:ローマ対策班で手を打つ<br>出発はX日後だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A110_080062")

	change_face(Actor006,"Sad")

	--★★エレイン★★:…
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001, Actor006, "J_Head")
lookat_delay_weight(Actor001, {1.1, 0.02, 0.4, 0} ,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレイン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_080064")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:…平気です、いけます
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080065")

-- ▼直接出力
keep_ik_lookat(Actor002, Actor006, "J_Head")
lookat_delay_weight(Actor002, {1.0, 0, 0.4, 0} ,0.6)
set_enable_auto_lookat(Actor006, true)
-- ▲直接出力

	--★★ギネヴィア★★:うそ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080066")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
set_enable_auto_lookat(Actor007, true)
-- ▲直接出力

	--★★エレイン★★:少し、怖いです
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080067")

-- ▼直接出力
lookat_delay_weight_default(Actor002, 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,92,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だいじょぶよ。一緒に行こ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080068")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,-68,0.5)
wait_time(0.5)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★エレイン★★:ギネヴィア様………っ
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_080069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:怖いもん、わたしも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_080070")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102030030_StillImage", "content_still_10203003_image", "102030030_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
