-- このluaスクリプトは、EA_069_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
keep_delay_ik_lookat(Actor001,Actor001,"J_Foot_L",0.2)
lookat_delay_weight(Actor001,0.25,0.1,0.45,0.2,0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
Appear(Actor002)
Appear(Actor003)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:はぁ…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220002")

-- ▼直接出力
wait_time(0.2)
PlayPartVoiceDirect("アーサー","0002")
se_play("SE_ADV_CO_101028_0302_Foot_Elegant")
wait_time(0.2)
se_play("SE_ADV_CO_101028_0302_Foot_Nomal")
-- ▲直接出力

	--★★アーサー★★:浮かない顔をしているな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220003")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
change_face(Actor001,"Surprise")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:！！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ギネマウア_004","0052")
-- ▲直接出力

	--★★ギネマウア★★:アーサー様！？それにマーリン様も…<br>どうしてこのようなところに？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220006")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:アーサー様はマーケットに出かけて<br>Ｂ級グルメを食べるのが趣味なのです
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:私はお目付け役として<br>こうしてたまに同行を
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220008")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:気晴らしは大切だからな！<br>ずっとデスクに座りきりでは息が詰まる！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220009")

	change_face(Actor002,"Normal")

	--★★アーサー★★:息が詰まったまま考えごとをすると<br>ろくなことを考えなくなる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だからたまにこうしてリフレッシュするんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.2)
lookat_delay_weight(Actor003,0.45,0.3,0.45,0.4,0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0025")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:あなたのそれは『たまに』というレベルでは<br>ありませんけどね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220012")

	change_face(Actor001,"Normal")

	--★★ギネマウア★★:気晴らし…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220013")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ところで…<br>ギネヴィアはいっしょではないのか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220014")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0052")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:あ…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220015")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力

	--★★アーサー★★:貴方がた姉妹こそ気晴らしが必要だと<br>俺は思うが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0002")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…お恥ずかしながら絶賛姉妹ケンカの真っ最中でして
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220017")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:なんと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220018")

-- ▼直接出力
setup_small_camera_start(RnaCamera090)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネマウア★★:一応、声はかけたんですよいっしょにマーケットを見て回らないかって
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0046")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ログレス自慢のマーケットをもってしても駄目か<br>それはなかなか難儀だな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220020")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:とすると…より高い気晴らしレベルが求められるのでしょうね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220021")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.2)
lookat_delay_weight(Actor002,0.45,0.4,0.45,0.4,0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:気晴らしレベルMAXというと…――なるほど、アレだな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220022")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.2)
lookat_delay_weight(Actor003,0.25,0.4,0.45,0.4,0.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:ええ、アレです
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220023")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:アレ…？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220024")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
wait_time(0.1)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
lookat_delay_weight(Actor002,0.45,0.4,0.45,0.4,0.2)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.2)
lookat_delay_weight(Actor003,0.45,0.4,0.45,0.4,0.2)
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:なんだと思う？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220025")

	open_select_window_tag(Actor001,"Normal","EA_069_0220027","EA_069_0220028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:美味しいご飯を食べる、とか？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.1)
--PlayPartVoiceDirect("マーリン_005","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:そうですね<br>もちろん、それも含まれます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だが、それだけじゃ足りないからな<br>もっとこう、全部盛りのヤツだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220033")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:？？？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0034")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:泥のように眠ること、とか
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220037")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:…お疲れなんだな、ギネマウア
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("マーリン_005","0038")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:いいと思います<br>遊び疲れた後には、ゆっくり眠れますから
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0220039")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:？？？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220040")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:気晴らしレベルMAX…<br>つまり楽しいことを全部やればいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220042")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:そのための時間ならある<br>なんたって今は――夏休みだからな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220043")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:夏休み…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220044")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そこで俺から提案だ<br>ここから少し離れたところに王家の別荘がある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:海も近いし、自然豊かないい場所だ<br>そこにふたりを招待しよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220046")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★アーサー★★:バーベキューに水遊び<br>夏のレジャーはひと通り楽しめる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220047")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:きっと良い気晴らしになるぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220048")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:お気持ちはありがたいのですが<br>そこまでしていただくのは…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220049")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0042")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:申し訳ない、などとは言わないでくれ<br>それはむしろこちらの台詞なのだから
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220050")

	change_face(Actor002,"Sad")

	--★★アーサー★★:お父上から貴方がた姉妹を託されておきながら<br>俺自身手一杯で、今日までなにもできずにいた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:故郷を離れてから今日まで<br>ずっと心休まるときがなかっただろうに
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0220052")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:………
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0220053")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
