-- このluaスクリプトは、MA_01B110_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113021_01_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113021_01_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_010)
	Camera003 = SetTemplate("Actor003",145,CharaPos113021_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_009)
	Camera004 = SetTemplate("Actor004",nil,CharaPos113021_01_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos113021_01_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_014)
	Camera006 = SetTemplate("Actor006",nil,CharaPos113021_01_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_013)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
set_pos(Actor004,{1,0.051,3.9})
change_face(Actor004,"Sad")
set_pos(Actor005,{0.4,0.051,0.1})
set_pos(Actor006,{-0.6,0.051,-1})
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor003,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","002","101034002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★エクセリア★★:拷問が最適解でしょうね
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:それで本音を吐くお前じゃない
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390003")

	change_face(Actor004,"Sad")

	--★★フィエナ★★:きっかけは、なに…？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_390004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")

	--★★フィエナ★★:友好的だったとはいえないけれど
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_390005")

	change_face(Actor004,"Anger")

	--★★フィエナ★★:お爺ちゃんは決して<br>円卓の騎士を嫌っていたわけじゃなかった
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_390006")

	PlayAction(Actor003,"to  Std_No")

	--★★リリアーナ★★:すききらいで…動く話ではありません
	Talk(Actor003,"CHRNAME_LILIANA2","speech","R","MA_01B110_390007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:こんなところで押し問答するほど暇なら<br>諸々のお勉強に時間を当てたほうが自分のためよ
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390008")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:なぜ…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390009")


	--★★アーサー★★:心の内を明かそうと思えるほど<br>まだログレスは愛されていないのだろうな？
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","MA_01B110_390010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
change_face(Actor003,"Surprise")
change_face(Actor004,"Surprise")
lookat_weight(Actor001,1,0.03,0.4,0)
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",1)
lookat_weight(Actor002,1,0.03,0.4,0)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1)
lookat_weight(Actor003,1,0.03,0.4,0)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1)
lookat_weight(Actor004,1,0.03,0.4,0)
keep_delay_ik_lookat(Actor004,Actor006,"J_Head",1)
Appear(Actor005)
Appear(Actor006)
--アーサー,CHRNAME_ARTHUR @名前変更
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,{-0.6,0.051,2.2},2)
wait_time(1.5)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{0.4,0.051,1.7},1)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:アーサー王…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390012")

-- ▼直接出力
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor006)
--アーサー,CHRNAME_ARTHUR @名前変更
set_rot(Actor001,{0,-120,0})
set_rot(Actor002,{0,170,0})
set_rot(Actor003,{0,180,0})
set_rot(Actor004,{0,-135,0})
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
lookat_delay_weight_reset(Actor004,1)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
	change_face(Actor006,"Smile")

	--★★アーサー★★:エクセリア、リリアーナ<br>遠路はるばる…歓迎するよ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:もう名前を覚えてくださっているとは<br>学長の鏡ね
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390014")

-- ▼直接出力
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:どうかな御両人<br>ほんの少しガラハッドが羨ましくはないか？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390015")

	change_face(Actor003,"Anger")

	--★★リリアーナ★★:これは…尋問ですか？
	Talk(Actor003,"CHRNAME_LILIANA2","speech","R","MA_01B110_390016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:お前たちと少し会わぬ間にガラハッドは<br>あまり知らない顔をしていたのではないか？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390017")


	--★★アーサー★★:銀卓の指示にはろくに従わぬ<br>ワガママな聞かん坊ではなかったはずだろう？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:だっ、だっ、誰がキカンボーだ！！<br>ガラハッドは、もう、分別がつくぞ！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390019")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
PlayActionDirect(Actor004,"to  Std_Joy")
turn_chara(Actor004,-165,0.3)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:おさえておさえて
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_390020")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor004,-135,0.5)
-- ▲直接出力

	--★★エクセリア★★:聖杯城にいた時からガラハッドはイイ子だったわ<br>今もイイ子よ、きっと必ずね
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390021")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:ガラハッドが私たちの言うことをきかないのは<br>私たちが道を違えたからです
	Talk(Actor003,"CHRNAME_LILIANA2","speech","R","MA_01B110_390023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:強い顔を見せてくれるようにはなったわね<br>それでアーサー王？なにが言いたいの？
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390024")

	PlayAction(Actor006,"to  Std_Worry")

	--★★アーサー★★:ガラハッドと同じ道を<br>歩んでみないかと言っているんだよ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390025")

-- ▼直接出力
turn_chara(Actor005,-55,0.5)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー★★:エクセリアとリリアーナに<br>しばらく学園で生活してもらいたい
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor005,"Normal","MA_01B110_390027","MA_01B110_390028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor006,"J_Head",1)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:俺のときと似たようなことを<br>やろうとしているわけか？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B110_390030")

	change_face(Actor001,"Sad")

	--★★ガラハッド★★:…ノワールも、かつてログレスの敵だったと聞く<br>だが状況が違うのではないか？彼女らは──
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390031")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★アーサー★★:若者は青春を謳歌するべきだ<br>戦いだけで一生を終えるべきではない
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390032")

	change_face(Actor006,"Smile")

	--★★アーサー★★:戦い以外の生活を知るべきだ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
keep_delay_ik_lookat(Actor005,Actor006,"J_Head",1)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:なにを言っている！？<br>ふたりは魔女と行動していたんだぞ？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B110_390035")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
lookat_weight(Actor006,1,0.03,0.4,0)
keep_delay_ik_lookat(Actor006,Actor005,"J_Head",1)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:お前もかつてはカレドニアと<br>行動をともにしていたわけだろう？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390036")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★フィエナ★★:じ、事情が違うんじゃない…？<br>彼女らたちは魔女と協力してたんだよ…
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_390037")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
keep_delay_ik_lookat(Actor006,Actor004,"J_Head",1)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:同じ境遇の者たちがこの学園にはいる<br>同じ時間を過ごしてもらえないだろうか
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390038")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera005)
lookat_delay_weight_reset(Actor006,1)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:彼女らがマスターを逃したのはどんな理由が？<br>銀卓の名を穢すような行いにはどんなワケが？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390040")


	--★★アーサー★★:不可思議だ。わからぬことばかりだ<br>だが一度は己の理解者とGSを果たした者たちだ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390041")

-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:我らと、根幹の気持ちには<br>違いがないように思う
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390043")

-- ▼直接出力
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★アーサー★★:たとえ…どうしようもない末路を<br>予期しての行動だとしても
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:アーサー…？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B110_390045")

-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:これは…まあ学園を作った時にな、思ってたんだ<br>居場所のない者には平等に寄る辺を与えたいと
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390046")

	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:寄る辺…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_390047")

	change_face(Actor006,"Smile")

	--★★アーサー★★:あとは俺の目が曇っていないことを祈るだけだ<br>これでなんかあったら俺が責任を取ろう！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★エクセリア★★:責任を…取らされることになりますよ<br>きっとね
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390050")

	PlayAction(Actor006,"to  Std_Angry")

	--★★アーサー★★:どんとこい！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
turn_chara(Actor006,115,0.5)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:そういうわけだ。それじゃ、ノワール！<br>後のことはよろしく頼むぞ！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390053")

	PlayAction(Actor005,"to  Std_Surp")

	--★★ノワール★★:え！？な、なんで！？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B110_390054")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:こういう立場には覚えがあるだろ？<br>先輩として、後輩たちの面倒を見てやってくれよ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to  Std_Talk")
turn_chara(Actor006,-10,0.5)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー★★:心置きなく青春を謳歌してもらおう！<br>…もっとも別途、監視役は付けさせてもらうが
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390056")

	change_face(Actor005,"Normal")

	--★★ノワール★★:監視役…？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B110_390057")

	change_face(Actor003,"Anger")

	--★★リリアーナ★★:…腹を割って話そう<br>というわけですか…？
	Talk(Actor003,"CHRNAME_LILIANA2","speech","R","MA_01B110_390059")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:存分に懐に入り込むといい<br>なあに、死に急ぐことはないさ！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B110_390060")


	--★★エクセリア★★:………それは<br>どちらのことかしらね
	Talk(Actor002,"CHRNAME_EXCELIA2","speech","R","MA_01B110_390062")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","002","101034002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
