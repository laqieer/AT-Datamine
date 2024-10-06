-- このluaスクリプトは、MA_01106_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera004 = SetTemplate("Actor004",-115,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
load_image("102010040_StillImage", "content_still_10201004_image", "102010040_StillImage")
load_image("MA011060601", "content_still_10101005_image", "101010050_StillImage")
Hide(Actor001)
set_pos(Actor001, {8, 0, 5})
set_pos(Actor007, {7, 0, 4})
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor006,"Smile")

	--★★モルガン★★:だからね、お引越ししましょ？
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060002")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Anger")

	--★★マルディサント★★:ざけんな！！<br>ゲッホゲホゲホゲー！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_060004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:マルディサント、やめようよ<br>ていうか大丈夫…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_060006")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★マルディサント★★:ヒキョーだぜ！アタシが納得しなかったら<br>「はいそうですか」ってヤメんのかよ！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_060008")

	PlayAction(Actor005,"to Greet_one")

	--★★アーサー★★:すまないがそれはないな！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060009")

	PlayAction(Actor004,"to  Std_Talk")

	--★★マルディサント★★:王様がそう言ってんだからそーなんだろーな！<br>アァーッ！やってらんねええー！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_060010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor007,Camera007,EntryData110051_01_07,CameraAssetBundleName110051_01,CameraPos110051_01_107,Actor001,CharaPos110051_01_003,CharaPos110051_01_103)
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★トリスタン★★:耳栓してくればよかった
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01106_060012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタン、マルディサント…どうして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:兄さん、あのね…<br>グラストンベリーの別荘が引き払われるんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_060014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:マルディサントも無関係の話じゃないから、って<br>それで…私も、心配でついてきて…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_060016")

-- ▼直接出力
show_image("102010040_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力

	--★★アーサー★★:ノワールたちのおかげで戦況は大きく変わった<br>キャメリアードを取り戻し、膠着状態は終わった
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060018")

-- ▼直接出力
setup_small_camera_start()
turn_chara(Actor001,205,0)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★アーサー★★:バルバロイを擁するカレドニアとの戦いは激化し<br>もはや止まることはないだろう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060019")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Sad")

	--★★モルガン★★:ログレス領とはいえ…グラストンベリーに<br>敵の手が伸びる可能性もなくはないわ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060020")

	change_face(Actor007,"Normal")

	--★★トリスタン★★:戦略的価値なんてほとんどない地だけど<br>バルバロイが西進し続けているこの状況下ではね
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01106_060021")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
hide_image(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:あそこには貴重な医療品の備蓄もある<br>万が一の状況に備え、使用人の避難も進めつつ…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060022")

	PlayAction(Actor004,"to  Std_Angry")

	--★★マルディサント★★:グラストンベリーにバルバロイが来たら<br>そんときはそんときだっての！！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_060023")

-- ▼直接出力
show_image("MA011060601", 0.0, 0.0, 0.6)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★モルガン★★:あそこはかつてね<br>アーサーの母イグレーヌ様の邸宅でもあったの
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060025")


	--★★モルガン★★:だから王族の品もある、遺品も、思い出も…<br>引き払うにしても慎重に、丁寧にしたいのよ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060026")

-- ▼直接出力
hide_image(0.3)
PlayActionDirect(Actor005,"to  Std_No")
turn_chara(Actor005,70,0.3)
-- ▲直接出力

	--★★アーサー★★:義姉さん、それはいいんだ<br>もう大したものは残っていないよ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
lookat_weight(Actor003,0.9,0.03,0.7,0.5)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.5)
PlayActionDirect(Actor005,"to Std_Loop")
turn_chara(Actor005,5,0.5)
-- ▲直接出力

	--★★ランスロット★★:思い出は多いほうがいい、アーサー
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060028")

	change_face(Actor005,"Sad")

	--★★アーサー★★:ランス…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060029")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor007)
on_camera(Camera007)
turn_chara(Actor001,-95,0)
lookat_weight(Actor001,0.7,0.03,0.7,0.5)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
 lookat_delay_weight_reset(Actor003,0.6)
set_enable_auto_lookat(Actor005,true)
lookat_delay_weight_reset(Actor005,0.6)
-- ▲直接出力

	--★★トリスタン★★:と、いうわけで<br>キミにはもったいない任務だけれど
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01106_060030")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力

	--★★ノワール★★:…ひ、引っ越しの手伝いか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060031")


	--★★ランスロット★★:リンゴ狩りだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,-120,0.5)
-- ▲直接出力

	--★★ノワール★★:リン…は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060035")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:リンゴ狩りだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060037")


	--★★ノワール★★:………リン、ゴ、が、り…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060038")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★モルガン★★:空気の綺麗な場所でピクニックとかどう？<br>ストレスにはね、自然を見るとイイらしいのよお
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060040")


	--★★ノワール★★:ピク…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Joy")

	--★★モルガン★★:グラストンベリーはね緑が豊かで<br>美味しいリンゴがたくさん栽培されているの
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01106_060042")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★アーサー★★:別荘の引き払いについて<br>雑務はログレスの兵にやらせるさ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ただ、万一バルバロイが襲ってきた場合は<br>騎士の力が必要になる
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060044")


	--★★アーサー★★:…というのは建前で
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060045")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,-165,0.3)
-- ▲直接出力

	--★★ノワール★★:なんだなんだなんだ…！？<br>引っ越し？リンゴ狩り？それとも護衛の任務か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060047")

	change_face(Actor005,"Sad")

	--★★アーサー★★:恐らくは<br>最後の休暇になる
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:カレドニアとの戦いが落ち着くまで<br>騎士たちには走り回り続けてもらうことになる
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060049")

	change_face(Actor005,"Normal")

	--★★アーサー★★:その前にせめてひとときでも<br>憩いの場を提供できないものか…考えていたんだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060050")


	--★★アーサー★★:戦勝の祝い事もうまくやってやれん<br>せめてもの感謝の気持ちだと受け取って欲しい
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")

	--★★マルディサント★★:なんでセンソー中にリンゴ狩りなんだよ<br>ありえねーー
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01106_060053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01106_060055","MA_01106_060056","MA_01106_060057")
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
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:きっとギネヴィアも喜ぶ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060059")

	change_face(Actor005,"Normal")

	--★★アーサー★★:ああ、キャメリアードの件で<br>ずっと張りつめていただろうことは明白だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060060")

	change_face(Actor005,"Smile")

	--★★アーサー★★:本当によくやってくれた<br>…ありがとう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060061")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンも連れて行っていいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060063")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…！<br>兄さん…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_060064")

	change_face(Actor005,"Smile")

	--★★アーサー★★:もちろんそのつもりだ！<br>無事儀式を乗り越えたお祝いも兼ねてな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060065")

	change_face(Actor005,"Smile")

	--★★アーサー★★:妹さんをリフレッシュさせてやれ<br>これまでの疲れも溜まっているだろう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060066")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットは行くのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060068")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…どっちがいい？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060070")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_060071")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:お前にとって…俺が行くか行かないか<br>どちらのほうがお前の心を休められる？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01106_060072")

	goto Block1end

::Block1end::
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★アーサー★★:出発はX日後、学園の守りはガウェインらが<br>引率兼護衛にはランスロットがつく
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060074")


	--★★アーサー★★:すまんな<br>B級のもてなしばかりで
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01106_060076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010040_StillImage", "content_still_10201004_image", "102010040_StillImage")
load_image_preload("MA011060601", "content_still_10101005_image", "101010050_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
