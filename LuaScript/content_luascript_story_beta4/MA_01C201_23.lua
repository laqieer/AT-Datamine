-- このluaスクリプトは、MA_01C201_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
Include("content_adv_advsmall_110051_04","110051_04_h")
Include("content_adv_advsmall_110051_04","Template110051_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
 --lookat_delay_weight(Actor001, 0.8,0,0.5,0.2,0.5)
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor002, 0.8,0,0.5,0.2,0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor003, 0.8,0,0.5,0.2,0.5)
keep_ik_lookat(Actor003, Actor002, "J_Head")
lookat_delay_weight(Actor005, 0.8,0,0.5,0.2,0.5)
keep_ik_lookat(Actor005, Actor002, "J_Head")
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110051_04,CameraPos110051_04_011)
	InitializeTemplateRandomCamera110051_04()
	InitializeTemplate110051_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:だが、動けるようになったギネヴィアは<br>ディナタンをアーサーのもとへ連れ去るのだった
	Talk(Actor007,"telop","narration","N","MA_01C201_231101")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C201_231102")


	--★★テロップ★★:ふたりがいなくなったって…！？<br>どういうことだ！
	Talk(Actor007,"telop","narration","N","MA_01C201_231103")


	--★★テロップ★★:そんなのアタシが聞きてえよ！<br>ギネヴィアの奴…
	Talk(Actor007,"telop","narration","N","MA_01C201_231104")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ふたりがいなくなったって…！？<br>どういうことだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230002")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:そんなのアタシが聞きてえよ！<br>ギネヴィアの奴…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230003")

	open_select_window_tag(Actor001,"Normal","MA_01C201_231001","MA_01C201_231002")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネヴィアが連れ去ったっていうのか！？<br>そんな、まさか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:ギネヴィアとふたりで病室にいたのは<br>間違いねえんだよ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230005")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:ディーナはずっとアイツの看病してて、<br>だからなんか差し入れしてやろうと思って
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230006")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:それでアタシがちょっと目を離した隙に…<br>気配が消えた…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230007")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:俺のせいだ<br>俺がディナタンから目を離したから…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_231003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★マーリン★★:自分をあまり責めないでください<br>…これは誰も予想ができなかったことです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01C201_231004")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:確かに…あのギネヴィアが<br>こんなにも大胆な行動に出るとはな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_231005")

	change_face(Actor003,"Normal")

	--★★ルーシャス★★:威勢がいいだけの仔猫と思っていたが<br>なにが彼女を変えたのであろうな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_231006")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:もと王妃サマもランスロットと同じく、<br>アーサーについたってことかぁ？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:そう考えるのが妥当であろう<br>だが…アーサーの目的はいったいなんなのだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_230009")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:全然わかんねえな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230010")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
turn_chara(Actor004, -102, 0)
turn_chara(Actor002, -125, 0)
Appear(Actor006)
 fadein(0.5)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定3")
-- ▲直接出力

	--★★モーロノエー★★:…やあね――
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","MA_01C201_230011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 --lookat_delay_weight(Actor001,1.0,0,0.6,0.2,0.5)
lookat_delay_weight(Actor003,0.9,0,0.5,0.2,0.5)
lookat_delay_weight(Actor005,1.0,0,0.5,0.2,0.5)
keep_ik_lookat(Actor001, Actor006, "J_Head")
keep_ik_lookat(Actor002, Actor006, "J_Head")
keep_ik_lookat(Actor003, Actor006, "J_Head")
keep_ik_lookat(Actor005, Actor006, "J_Head")
template2()
setup_small_camera_start(Camera006)
hide_image()
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
--モーロノエー,CHRNAME_SISTERS_1 @名前変更
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★モーロノエー★★:私が下っ端扱いなんて<br>なんで私が連絡係なのよ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:…魔女！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230014")


	--★★モーロノエー★★:聞いた？<br>もう大姉様もいないの
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230015")

	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "激怒")
-- ▲直接出力

	--★★モーロノエー★★:ぜーんぶ、あいつのせい
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:…あいつ…アーサーか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:そう、あいつ<br>でも私は生き延びるつもりだけど
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230018")


	--★★モーロノエー★★:頭を地に擦りつけて<br>這いつくばってでも
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230019")


	--★★モーロノエー★★:だから伝言にきたの<br>継承者と偉大なる魔女に
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230020")

	change_face(Actor005,"Surprise")

	--★★マーリン★★:………！
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01C201_230021")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:魔女？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230022")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★モーロノエー★★:でしょう？ね、マーリン
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230023")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★マーリン★★:…私は
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01C201_230024")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★モーロノエー★★:自分は違うって？<br>あらァ、いいご身分！
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230025")

	change_face(Actor006,"Normal")

	--★★モーロノエー★★:でも本当に、絶対違うって言いきれる？<br>ほんとにほんとに？
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230026")

-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:………
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01C201_230027")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定2")
-- ▲直接出力

	--★★モーロノエー★★:妖精ってほんとに身勝手ねェ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モーロノエー★★:人間に愛されるだけ愛されて<br>なのに自分は綺麗なままで死ぬなんて
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230029")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力

	--★★モルドレッド★★:なんだ…？<br>なにを言ってやがる！？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230031")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定3")
-- ▲直接出力

	--★★モーロノエー★★:理解が遅いのね<br>王様になれないわけだわ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230032")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モルドレッド★★:なんだと…！
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230033")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:簡単な話じゃない<br>アーサーは、あなたたちを捨てたの
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230034")

	PlayAction(Actor006,"to  Std_Talk")

	--★★モーロノエー★★:そうでしょう？<br>湖の妖精さん
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230035")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:…マーリンさんが、湖の妖精…？<br>いったい、どういうことだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230037")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定2")
-- ▲直接出力

	--★★モーロノエー★★:でも捨てるのもわかるわよねえ<br>バルバロイが穢れているなんて失礼な話
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230038")


	--★★モーロノエー★★:ねえ、ローマはそう思うでしょ？
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力

	--★★ルーシャス★★:ここでローマを引き合いに出す<br>理由がわからんな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_230041")

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:だってローマは知っているはずよ<br>穢れた血なんて本当は
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230042")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:為政者が作り出したものだと？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_230043")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★モーロノエー★★:さすがローマの皇帝！<br>話が分かるわね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230044")

	change_face(Actor006,"Normal")

	--★★モーロノエー★★:ログレスの王も同じことを思ってるのかもね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230045")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:なにを…いったい<br>なにを言ってるんだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_230046")


	--★★モーロノエー★★:これで無駄話はおしまい
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230047")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:懐かしいお城でギネヴィア嬢が<br>お待ちよ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230048")


	--★★モーロノエー★★:継承者様と湖の妖精をね<br>もしかするとアーサーも一緒かも
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力

	--★★モーロノエー★★:さようなら<br>ログレスの人たち
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230050")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力

	--★★モルドレッド★★:…待て！
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230051")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "肯定")
-- ▲直接出力

	--★★モーロノエー★★:うん、待ってる<br>キャメリアード城でね
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C201_230052")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor006)
 --turn_chara(Actor002, -142, 0)
 --turn_chara(Actor004, -120, 0)
lookat_delay_weight_reset(Actor002 , 1)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:罠にしか思えないが<br>どうするのだ、継承者
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C201_230054")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力

	--★★モルドレッド★★:どうもこうもねぇ<br>ぶっ潰すしかねえだろ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C201_230055")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力

	--★★マルディサント★★:…ディーナ――…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C201_230056")

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
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest(CameraAssetBundleName110051_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
