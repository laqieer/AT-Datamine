-- このluaスクリプトは、MA_01C110_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{1.117,0.035,6.995})
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:アーサーはバルバロイと手を結んだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340002")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★パーシヴァル★★:ま、間違いないのかい…？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_340003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:間違いない…いや少なくとも<br>バルバロイたちと動いていることは間違いない
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C110_340004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:そんな…
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_340005")

	PlayAction(Actor007,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ディナタン★★:どうして…<br>だってあんなに学園を大事にしてたのに
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01C110_340007")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:さぁな<br>俺たちが知りてえよ、そんなもん
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_340008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:ひとつ明らかなことは<br>アーサーはディナタンを狙っていたということだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340009")


	--★★ランスロット★★:それはお前たちもわかっているだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_340011","MA_01C110_340012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーはなぜ<br>バルバロイと手を結んだんだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーはバルバロイを憎んでいたはずだ<br>じゃなきゃ学園を発展させようなんてしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340015")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…アーサーの行動を信じられないのは皆同じだ<br>しかしそう判断せざるを得ない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:今でもアーサーの行動は信じられない<br>でも…ディナタンを渡すわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の大事な…<br>大事な妹だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340019")

	change_face(Actor007,"Sad")

	--★★ディナタン★★:兄さん…ありがとう
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01C110_340020")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:アーサーだけではない<br>モルガンも同様に行方が知れない
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C110_340022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:つまり円卓は崩壊しつつある<br>我々は存在意義を根底から問われている
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C110_340023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーの目的は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:今のところはお前とディナタンだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340025")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:お前たちがいた森に<br>バルバロイを送ったのも恐らくアーサーだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340026")


	--★★ランスロット★★:お前たちがいない短いあいだにも<br>幾度となく学園はバルバロイに襲われた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340027")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:調べではアーサーが<br>バルバロイを率いているという
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340028")

-- ▼直接出力
setup_small_camera_start(Camera007)
Appear(Actor006)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ディナタン★★:そんな…どうして…
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","MA_01C110_340029")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★マーリン★★:私がアーサー様を止められなかったのです
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01C110_340031")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,CharaPos110051_02_014[1],CharaPos110051_02_014[2],CharaPos110051_02_014[3],0.8)
wait_time(0.4)
setup_small_camera_start(Camera006)
wait_time(0.4)
turn_chara(Actor006,CharaPos110051_02_014[4],0.1)
wait_time(0.1)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★マーリン★★:アーサー様は王として<br>自らの今までの道を否定されました
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01C110_340032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:故にアーサー様はユーサー様が作られた<br>ログレスを亡きものにしようとしています
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01C110_340033")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★マーリン★★:――「間違いを、正さねばならない」と
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01C110_340034")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういう意味ですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:世界にはまだ知られていないことが<br>あるのかもしれない…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_340037")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_340038")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
